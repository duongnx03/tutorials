import{ useState} from "react";
import { useNavigate } from "react-router-dom";

function Create({handleCreate}){
    const [newStudent, setNewStudent] = useState({});
    const navigate = useNavigate();

    return(
        <div>
            <h1>Create new Student</h1>
            <div>
                Name: <input value={newStudent.name} onChange={(e) => 
                                setNewStudent({...newStudent, name:e.target.value})}/>
            </div>
            <div>
                Email: <input value={newStudent.email} onChange={(e) => 
                                setNewStudent({...newStudent, email:e.target.value})}/>
            </div>
            <div>
                Mark: <input value={newStudent.mark} onChange={(e) => 
                                setNewStudent({...newStudent, mark:e.target.value})}/>
            </div>
            <button onClick={(e)=> 
            {handleCreate(newStudent); 
            navigate('/home')
            }}>Create</button>
                </div>
    );
}

export default Create;