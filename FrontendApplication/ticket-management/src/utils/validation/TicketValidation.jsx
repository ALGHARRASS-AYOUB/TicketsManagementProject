export const validateTicket = (ticket) => {
    let errors = {};
  
    if (!ticket.description) {
      errors.description = "Description is required";
    }
  
    if (!ticket.status) {
      errors.status = "Status is required";
    }
  
    return errors;
  };
  