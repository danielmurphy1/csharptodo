import React, { useState, useRef, useEffect } from 'react';
import { Container } from 'react-bootstrap';
import Header from './Components/Header';
import InputForm from './Components/InputForm';
import ToDoList from './Components/ToDoList';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import axios from 'axios';


function App() {
  const inputTextRef = useRef();
  const [ todos, setTodos ] = useState([]);

  function handleAddToDo(event){
    event.preventDefault();

    const enteredToDoInput = inputTextRef.current.value;
    console.log(enteredToDoInput);
    setTodos([...todos, enteredToDoInput]);
    console.log(todos);
    inputTextRef.current.value = "";
  }

  async function getToDos(){
    const response = await axios.get('/api/todos');
    const newToDos = response.data;
    setTodos(newToDos);
  }

  useEffect(() => {
    getToDos();
  }, []);

  return (
      <Container className="App">
        <Header />
        <InputForm inputTextRef={inputTextRef} handleAddToDo={handleAddToDo} />
        <ToDoList todos={todos}/>
      </Container>


  );
}

export default App;
