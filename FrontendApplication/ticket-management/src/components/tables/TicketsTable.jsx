import React, { useContext, useState } from 'react';
import { TicketContext, useTicket } from '../../context/TicketContext';
import { toast, ToastContainer } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import { Badge, Card, CardHeader, Container, Row, Spinner, Table } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';

const TicketsTable = ({alltickets,setAllTickets}) => {
  const navigate = useNavigate();
  const { tickets,fetchTickets, deleteTicket, updateTicket,ticket,loading } = useTicket('')
  const [ticketsToMap,setTicketsToMap]=useState();

  const fetch=async()=>{
    const listTickets = await fetchTickets();
    setAllTickets(alltickets)
    setTicketsToMap(alltickets)
 }

function editTicket(ticketId) {

  return navigate('/tickets/editTicket', {
    state: {
      ticketId: ticketId,
    },
  });
}


async function deleteTicketById(id) {
  const res = await deleteTicket(id);
  if (res.status == 204) {
    toast.success('ticket Deleted succesfully');
  }else{
    toast.error('cannot delete ticket');

  }
   await fetchTickets()
  setAllTickets(tickets)

}


  return (
    <>
    
      <Container>
      <ToastContainer>

</ToastContainer>

        <Row>
          {/* <ToastContainer> */}
            <Card className='strpied-tabled-with-hover'>
              <CardHeader>
                <Card.Title as='h4'>Tickets</Card.Title>
                
                {loading && <Spinner animation='grow' />}
              </CardHeader>

              <Card.Body className='table-full-width table-responsive px-0'>
              <Table className='table-hover '>
              <table className="table">
                        <thead>
                          <tr>
                            <th className='border-0'>Ticket Id</th>
                            <th className='border-0'>Description </th>
                            <th className='border-0'>Status </th>
                            <th className='border-0'>Date </th>
                            <th>Actions</th>
                          </tr>
                        </thead>

                      <tbody>
                          {alltickets.map(t => (
                            <tr key={t.ticketId}>
                              <td>{t.ticketId}</td>
                              <td>{t.description}</td>
                  
                              <td>{t.status == 0 ? <Badge   pill bg="success">Open</Badge>:<Badge pill  bg="danger">Closed</Badge>}</td>
                              
                              <td>{new Date(t.date).toLocaleDateString('en-US', { month: 'short', day: 'numeric', year: 'numeric' })}</td>
                              <td>
 
                              <a href="#" onClick={() => editTicket(t.ticketId)}>Update</a> | 
                              <a href="#" onClick={() => deleteTicketById(t.ticketId)}>Delete</a>
                              </td>
                            </tr>
                          ))}
                        </tbody>
                  </table>

              </Table>
              </Card.Body>
            </Card>
  
          {/* </ToastContainer> */}
        </Row>
      </Container>


    </>
  );
};

export default TicketsTable;
