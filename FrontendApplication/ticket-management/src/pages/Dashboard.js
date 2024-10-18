import { Link, useLocation, useNavigate } from "react-router-dom"
import Tickets from "../components/tickets/Tickets";
import CreateTicket from "../components/tickets/CreateTicket";
import EditTicket from "../components/tickets/EditTicket"; 


const Dashboard=()=>{

    const navigate=useNavigate()
    const location=useLocation()
    location.pathname=<Tickets/>


    const getRoutes = () => {
        switch (location.pathname) {
  
            case "/":
                return <Tickets />;
            break;

            case "/tickets":
                return <Tickets />;
            break;
  
            case "/tickets/createTicket":
              return <CreateTicket/>
            break;
            
            case "/tickets/editTicket":
                return <EditTicket/>
            break;

            
            default:
                      return <Tickets/> 
                 break;
 
        }
      };


      return (
        <>

        {getRoutes()}
        </>
      ) ;
}
export default Dashboard;