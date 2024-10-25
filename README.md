
## Overview

**Ticket Management** is a web-based application designed to manage tickets, providing basic CRUD (Create, Read, Update, Delete) functionalities. It is built with a modern stack, leveraging:

- **Frontend**: React `^18.3.1`
- **Backend**: .NET 8.0 Web API
- **Database**: PostgreSQL

The application allows users to create, view, update, and delete tickets. It also includes features like pagination, filtering, and sorting for an enhanced user experience.

## Features

- **Create New Ticket**: Users can create new tickets with details such as description, status (Open/Closed), and date.
- **View Tickets**: View a list of all tickets in a table format with pagination.
- **Update Ticket**: Edit the details of an existing ticket, including updating its status.
- **Delete Ticket**: Remove tickets that are no longer needed.
- **Pagination**: Efficiently paginate through large ticket lists.
- **Client-side Validation**: Ensures that the required fields are filled when creating or updating tickets.
- **Real-time Notifications**: Feedback on successful or failed CRUD operations using React-toastify.
- **Filtering and Searching**: Filter list by open or closed tickets. Search tickets by description as well.

## Prerequisites

Before you begin, make sure you have the following software installed on your machine:

- **Docker**: Install Docker
- **Docker Compose**: Install Docker Compose

## Run the Application

Follow these steps to run the application using Docker:

1. Clone the repository to your local machine:
    `git clone https://github.com/ALGHARRASS-AYOUB/TicketsManagementProject.git
    
2. Use Docker to run the backend (PostgreSQL, .NET API) and the frontend (React) services. In the root directory where `docker-compose.yml` is located, execute the following command:
    `docker compose -f docker-compose.yml up --build -d`
    the application is automated for deployment. the postgresql database will be initialized with the scripts and configuration provided in initializer folder.
    - **Note**: for Devlopement I used Entity Framework Code First for database migration. So if you intend to use Devlopement environment you can proceed with this approach. 

    This command will build and run the required services:
    
    - **db**: PostgreSQL database for storing tickets.
    - **backend**: .NET 8.0 Web API service for managing the tickets (CRUD operations).
    - **frontend**: React app providing the user interface for the ticket management system.
3. After the services start, you can access the application:
    
    - **Frontend**: Navigate to `http://localhost:80/tickets` in your browser to view the ticket management interface.
    - **Backend API**: The .NET API is exposed at `http://localhost:5059`.

## Usage

Once the application is running, you can interact with the ticket management system:
- use the endpoint : `localhost/tickets`

- **Add Ticket**: Click the "Add New" button to create a new ticket.
- **View Tickets**: Tickets are displayed in a paginated table, with options to update or delete each ticket.
- **Update/Delete**: Use the "Update" and "Delete" buttons in the Actions column to modify or remove tickets.

## Technology Stack

- **Frontend**:
    - React: `^18.3.1`
    - Bootstrap for styling
    - React-toastify for CRUD operation notifications
- **Backend**:
    - .NET 8.0 Web API
    - Entity Framework Core (Code-First Approach)
    - PostgreSQL database