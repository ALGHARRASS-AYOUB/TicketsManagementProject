import { useContext, useEffect, useState } from 'react';
import { Button, Col, Container, Form, Row, ToastContainer } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
import TicketsTable from '../tables/TicketsTable';
import { TicketContext, useTicket } from '../../context/TicketContext';



function Tickets() {

  const navigate = useNavigate('');
  const { getTicketsByStatus,tickets,pageinfo,openTickets,closedTickets,statusTickets,fetchTickets, deleteTicket, updateTicket,ticket,loading } = useTicket('');
  const [items,setItems]=useState([]);
  const [filtredData, setFiltredData] = useState([]);
  const [pageNumber, setPageNumber] = useState(1);  
  const [pageSize] = useState(5);  
  const [totalPages, setTotalPages] = useState(0);

  const [filter,setFilter]=useState('all')

  const handlePageChange = (e,newPage) => {
    e.preventDefault()
    setPageNumber(newPage)
    if (newPage >= 1 && newPage <= totalPages) {
      fetchData()
    }
  };

  const fetchData = async () => {
    const res=await fetchTickets( pageNumber,pageSize);
    setFiltredData(res?.tickets)
    setTotalPages(res?.totalPages)
    

  };
  
  const updateTable =async (v = null, searchKey = null) => {
    setFilter(v)
    if (v != null && searchKey == null) {
      
      switch (v) {
        case 'open' :
         const reso=await getTicketsByStatus(0,pageNumber,pageSize)
          setFiltredData(reso?.tickets)
            setItems(reso?.tickets)
          break;
        case 'closed':
          const resc=await getTicketsByStatus(1,pageNumber,pageSize)
          setFiltredData(resc?.tickets)
          setItems(resc?.tickets)

          break;

        case 'all':
          setFiltredData(tickets)
          setItems(tickets)

          break;
        default:
          break;
    

      }
      
    }
      if(searchKey != null && v == null){
      
      const data = items.filter(item => {
        return item.description.toLowerCase().search(searchKey.toLowerCase()) != -1;
      });
      setFiltredData(data);
    }
  };

  useEffect(() => {
    fetchData()

  }, [pageNumber,totalPages]);

  return (
    
    <Container>
                <ToastContainer>
                  </ToastContainer>
      <h1 className='p-2 mt-2' style={{  borderBottom: '3px solid #365b81' }}><i className='mx-1 fa fa-building'></i> tickets </h1>
      <Row className='m-4'>
        <Col md='6'>
          <Form.Select
            aria-label='ticket filtring'
            onChange={e => updateTable(e.target.value,null)}
          >
            <option value='all'>All</option>
            <option value='open'>open</option>
            <option value='closed'>closed</option>
          </Form.Select>
        </Col>
        <Col md='6'>
          <Form.Control
            placeholder='Search Ticket'
            aria-label='Search Ticket'
            aria-describedby='basic-addon2'
            onChange={(e)=>updateTable(null,e.target.value)}
          />
        </Col>
      </Row>
      <Row className='mx-1 my-4'>
        <Col>
        <Button variant="primary" size="lg" className='text-white fw-bold ' href='/tickets/createTicket'>
            add Ticket <i className='mx-3 fa fa-plus-square '></i>
        </Button>
      
        </Col>
      </Row>
      <TicketsTable alltickets={filtredData} setAllTickets={setFiltredData} />
      <Row className='mx-2 my-4'>
      <div className="pagination-controls">
            <Button
              variant="secondary"
              onClick={(e) => handlePageChange(e,parseInt(pageNumber) - 1)}
              disabled={pageNumber === 1}
            >
              Previous
            </Button>
            <span>{` Page ${pageNumber} of ${totalPages} `}</span>
            <Button
              variant="secondary"
              onClick={(e) => handlePageChange(e,parseInt(pageNumber) + 1)}
              disabled={parseInt(pageNumber) === parseInt(totalPages)}
            >
              Next
            </Button>
          </div>
      </Row>
    </Container>

  );
}
export default Tickets;