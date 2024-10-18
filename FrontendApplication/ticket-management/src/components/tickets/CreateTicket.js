import React, { useEffect, useState } from 'react'
import { Button, Col, Container, FloatingLabel, Form } from 'react-bootstrap'
import { Link, useNavigate, useParams } from 'react-router-dom'
import { toast, ToastContainer } from 'react-toastify'
import { useTicket } from '../../context/TicketContext'
import moment from 'moment'

 const CreateTicket = () => {
  const {ticketById,ticket,addTicket}=useTicket('')
  const [item,setItem]=useState()
  const [date,setDate]=useState()
  const [status,setStatus]=useState()
  const [description,setDescription]=useState()
  const [ticketId,setticketId]=useState()
  const navigate=useNavigate()


const handleSubmit=(e)=>{
  const createdTicket={description, status,date}
  console.log("createdTicket ticket: ",createdTicket)
  setItem(createdTicket)
  console.log("created ticket item: ",item)
  e.preventDefault()
   store();
}



const store=async()=>{
  console.log("create item:" , item)
  const res=await addTicket({description, status,date})
  console.log("res addTicket:" , res)
  
   if(res.status==201)
    toast.success('the ticket has been created')
  else
  toast.error('the ticket connot be created')
  
}

useEffect(()=>{

  },[])
  
  



  return (
   
   
    <Container className='m-5'>

    <ToastContainer>

    </ToastContainer>
    
  <h3 className="fw-normal mb-5">add new Ticket</h3>

    { 
      <>

      <FloatingLabel controlId="floatingTextarea2" className='py-2 mb-4' label="Description">
      <Form.Control
      className=''
        as="textarea"
        placeholder="Leave a description here"
        style={{ height: '100px' }}
        value={ description}
        onChange={e=>{setDescription(e.target.value)}}
      />
    </FloatingLabel>


    <div className="my-5 pb-2">
        <div className="form-outline form-white">
          <label className="form-label" for="status">Status Ticket :</label>
          <Form.Select id='status' name='status' onChange={(e)=>{ setStatus(parseInt(e.target.value))}} size="sm">
              <option value={0} >Open</option>
              <option value={1} >Closed</option>
          </Form.Select>
        </div>
      </div>

      <Col className='m-2'>
        <label htmlFor="date"> date : </label><Form.Control format='Y-m-d H:i:s'  value={ moment(new Date(date)).format('YYYY-MM-DD')} type='Date'   name='date' min={moment(Date.now()).format("YYYY-MM-DD") }    onChange={e=>{setDate(moment(e.target.value).format('YYYY-MM-DDTHH:mm:ss.SSS[Z]'))} }    />
       </Col>

      <div className="mt-4  pb-2">
        <div className="form-outline form-white">
        <Button className='btn btn-success' type='submit' onClick={e=>handleSubmit(e)} >Create</Button>
        </div>
      </div>         

      <div className="my-2 ">
        <div className="form-outline form-white">
        <Link className='btn btn-secondary' to='/tickets' ><i className='mx-1 fa fa-chevron-left'> BACK</i></Link>
        </div>
      </div>    

            </>
    }

</Container>
          
  );
}

export default CreateTicket;