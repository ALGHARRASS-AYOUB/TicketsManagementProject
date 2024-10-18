import React, { useEffect, useState } from 'react'
import { Button, Col, Container, FloatingLabel, Form } from 'react-bootstrap'
import { Link, useLocation, useNavigate, useParams } from 'react-router-dom'
import { toast, ToastContainer } from 'react-toastify'
import { useTicket } from '../../context/TicketContext'
import moment from 'moment'

const EditTicket = () => {
const {ticketById,ticket,updateTicket}=useTicket('')
const [item,setItem]=useState()
const [date,setDate]=useState()
const [status,setStatus]=useState()
const [description,setDescription]=useState()
const [ticketId,setticketId]=useState()
const navigate=useNavigate()
const { state } = useLocation();



const handleSubmit=(e)=>{
  const updatedTicket={ticketId,description, status,date}
  console.log("updated ticket: ",updatedTicket)
  setItem(updatedTicket)
  console.log("updated ticket item: ",item)
  e.preventDefault()
  update();

}

 const fetchTicket=async()=>{
  console.log("id value: ",state.ticketId)
 const res=await ticketById(state.ticketId);
  console.log("fetchin ticket  for update ticket res",res.data)
  setticketId(state.ticketId)
  setItem(res?.data)
  setDate(res?.data.date)
  setDescription(res?.data.description)
  setStatus(res?.data.status)
}

const update=async()=>{
console.log("update item:" , item)
const res=await updateTicket(ticketId,{ticketId,description, status,date})
console.log("res update:" , res)

 if(res.status==204)
  toast.success('the ticket has been updated')
else
toast.error('the ticket connot be updated')

  // navigate('/tickets')
}

  // Fetch the ticket when the component mounts
  useEffect(() => {
    fetchTicket();
  }, []);



  return (
   
            <Container className='m-5'>

              <ToastContainer>

              </ToastContainer>
              
            <h3 className="fw-normal mb-5">Update Ticket</h3>
  
              { item &&
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
                    <label className="form-label" for="stats">Status Ticket :</label>
                    <Form.Select id='status' name='status' onChange={(e)=>{ setStatus(parseInt(e.target.value))}} size="sm">
                        <option value={0} selected={status==0 }>Open</option>
                        <option value={1} selected={status==1 }>Closed</option>
                    </Form.Select>
                  </div>
                </div>

                <Col className='m-2'>
                  <label htmlFor="date"> date : </label><Form.Control format='Y-m-d H:i:s'  value={ moment(new Date(date)).format('YYYY-MM-DD')} type='Date'   name='date' min={moment(Date.now()).format("YYYY-MM-DD") }    onChange={e=>{setDate(moment(e.target.value).format('YYYY-MM-DDTHH:mm:ss.SSS[Z]'))} }    />
                 </Col>

                <div className="mt-4  pb-2">
                  <div className="form-outline form-white">
                  <Button className='btn btn-success' type='submit' onClick={e=>handleSubmit(e)} >Update</Button>
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
          
  )
}

export default EditTicket;