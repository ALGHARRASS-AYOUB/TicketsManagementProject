import React, { createContext, useContext, useState } from 'react';
import axios from 'axios';
import { getUrl } from '../api';
import { useNavigate } from 'react-router-dom';
import { toast } from 'react-toastify';

const TicketContext=createContext();
export const useTicket=()=>{
    const context=useContext(TicketContext)
    if(!context) throw new Error('ticket provider does not exist')
    return context;
}
        


export const TicketProvider = ({ children }) => {
  const navigate=useNavigate();
  const [tickets, setTickets] = useState([]);
  const [pageinfo, setPageInfo] = useState([]);
  const [openTickets, setOpenTickets] = useState([]);
  const [statusTickets, setStatusTickets] = useState([]);
  const [closedTickets, setClosedTickets] = useState([]);
  const [ticket, setTicket] = useState([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);


  const fetchTickets = async (page = 1,size=10) => {
    const config={
      headers:{
           'content-type':'application/json'
      }
    };

    setLoading(true);
    try {


      const response = await axios.get(`${getUrl('Tickets')}?pageNumber=${page}&pageSize=${size}`,config);
      setTickets(response.data.tickets);
      setPageInfo({"pageNumber":response.data.pageNumber,"totalPages":response.data.totalPages})
      return response.data
    } catch (err) {
      toast.error('an error has been occured while fetching data')
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };


  const getTicketsByStatus = async (status,page = 1,size=10) => {
    const config={
      headers:{
           'content-type':'application/json'
      }
    };

    setLoading(true);
    try {
      let URL=''
      if(status==0){
        URL=`${getUrl('Tickets')}/open?pageNumber=${page}&pageSize=${size}`
  
        const response = await axios.get(URL,config);
        setOpenTickets(response.data.tickets);
        setPageInfo({"pageNumber":response.data.pageNumber,"totalPages":response.data.totalPages})
        return response.data
      }
      if(status==1){
        URL=`${getUrl('Tickets')}/closed?pageNumber=${page}&pageSize=${size}`
        const response = await axios.get(URL,config);
        setClosedTickets(response.data.tickets);
        setPageInfo({"pageNumber":response.data.pageNumber,"totalPages":response.data.totalPages})
        return response.data

      }

    } catch (err) {
      toast.error('an error has been occured while fetching data')
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  const ticketById = async (id) => {
    const config={
      headers:{
           'content-type':'application/json'
      },
    };
    
    try {
      const response=await axios.get(`${getUrl('Tickets')}/${id}`,config);
      setTicket(response.data)
      return response;
    } catch (err) {
      toast.error('an error has been occured while fetching data')  
      setError(err.message);
    }
  };


  const addTicket = async (ticket) => {
    const config={
      headers:{
           'content-type':'application/json'
      },
    };
    
    try {
      const response=await axios.post(getUrl('Tickets'), ticket,config);
      fetchTickets();
      return response
    } catch (err) {
      setError(err.message);
    }
  };


  const updateTicket = async (ticketId,ticket) => {
    const config={
      headers:{
           'content-type':'application/json'
      },
    };

    try {
      const response=await axios.put(`${getUrl('Tickets')}/${ticketId}`, ticket,config);
       fetchTickets();
       return response;
    } catch (err) {
      setError(err.message);
    }
  };

  const deleteTicket = async (id) => {
    const config={
      headers:{
           'content-type':'application/json'
      },
    };
    
    try {
      const response=await axios.delete(`${getUrl('Tickets')}/${id}`,config);
      fetchTickets();
      return response
    } catch (err) {
      setError(err.message);
    }
  };

  return (
    <TicketContext.Provider
      value={{ pageinfo,getTicketsByStatus,ticketById,tickets,openTickets,closedTickets,statusTickets, loading, error, fetchTickets, addTicket, updateTicket, deleteTicket }}
    >
      {children}
    </TicketContext.Provider>
  );
};
