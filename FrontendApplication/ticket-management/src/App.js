import { TicketProvider } from './context/TicketContext';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css'
import Dashboard from './pages/Dashboard';
import { Link, Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import Tickets from './components/tickets/Tickets';

import EditTicket from './components/tickets/EditTicket';
import CreateTicket from './components/tickets/CreateTicket';

function App() {
  return (
    <>
      <Router>
         <TicketProvider>
          <Routes>
           <Route path="/tickets" element={ <Tickets/>} />
           {/* <Route path="/tickets/" element={ <Tickets/>}/> */}
            <Route path="/tickets/createTicket" element={ <CreateTicket/>}/>
           
            <Route path="/tickets/editTicket" element={ <EditTicket/>}/>
          </Routes>
        </TicketProvider>
      </Router>
     
    </>
      

  );
}

export default App;
