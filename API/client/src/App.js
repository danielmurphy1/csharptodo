import React from 'react';
import { Container } from 'react-bootstrap';
import Header from './Components/Header';
import InputForm from './Components/InputForm';
import ToDoList from './Components/ToDoList';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';


function App() {
  return (
      <Container className="App">
        <Header />
        <InputForm />
        <ToDoList />
      </Container>


  );
}

export default App;
