function Home({students, loading, handleDelete}){
    return (
        <div>
            <h1>List Student</h1>
            <table>
                <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Mark</th>
                    <th>Action</th>
                </tr>   
                </thead>
                <tbody>
                    {students.map(stu =>(
                        <tr key={stu.id}>
                            <td>{stu.id}</td>
                            <td>{stu.name}</td>
                            <td>{stu.email}</td>
                            <td>{stu.mark}</td>
                            <td>
                                <button onClick={(e) => handleDelete(stu.id)}>Delete</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    )
}

export default Home;