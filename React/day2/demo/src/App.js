import { Link, Route , Routes} from 'react-router-dom';
import './App.css';
import About from './components/About';
import Home from './components/Home';
import Create from './components/Create';
import { useState, useEffect } from 'react';
import axios from 'axios';

function App() {
  const [students, setStudents] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect( () => {
    const fetchData = async () => {
      try{
        const response = await axios.get('https://localhost:7287/api/Student/');
        setStudents(response.data);
      }catch(error){
        console.log('Error fetching data', error);
      }finally{
        setLoading(false);
      }
    };

    fetchData();
  }, []);

  const handleCreate = async (newStudent) => {
    try{
      const response = await axios.post('https://localhost:7287/api/Student/', newStudent);
      setStudents([...students, response.data]);
    }catch(error){
      console.error("error create student", error)
    }
  }

  const handleDelete = async (id) => {
    try{
      const response = await axios.post(`https://localhost:7287/api/Student/${id}`);
      setStudents(students.filter(stu => stu.id != id));
    }catch(error){
      console.error("error delete student", error)
    }
  }


  return (
    <div className="App">
      <nav>
        <Link to='/home'>Home  / </Link>
        <Link to='/create'>Create  /</Link>
        <Link to='/about'>About</Link>
      </nav><br></br>

      <Routes>
        <Route path='/home' element={<Home students={students} loading={loading} handleDelete={handleDelete}/>}/>
        <Route path='/create' element={<Create handleCreate={handleCreate}/>}/>
        <Route path='/about' element={<About/>}/>
      </Routes>
    </div>
  );
}

export default App;
