import { useEffect, useState } from 'react';
import Home from './components/Home';
import axios from 'axios';

function App() {
  const [name, setName] = useState('nam');
  let num = 2;
  const [products, setProducts] = useState([]);
  const [loading, setLoading] = useState(true);
  const [newProduct, setNewProduct] = useState({});

  useEffect( () => {
    const fetchData = async () => {
      try{
        const response = await axios.get('https://localhost:7139/api/Product/');
        setProducts(response.data);
      }catch(error){
        console.log('Error fetching data', error);
      }finally{
        setLoading(false);
      }
    };

    fetchData();
  }, []);

  const handleCreate = async () => {
    try{
      const response = await axios.post(`https://localhost:7139/api/Product/`, newProduct);
      setProducts([...products, response.data]);
    }catch(error){
      console.log('Erre create data', error);
    }
  }

  console.log(products);
  return (
    <div>
      <Home/>
      <p>num: {num}</p>
      <input value={name} onChange={(e) => setName(e.target.value)}/>


      <h1>Create new Product</h1>
      <div>
        name: <input value={newProduct.name} onChange={(e) => 
                          setNewProduct({...newProduct, name:e.target.value})}/>
      </div>
      <div>
        price: <input value={newProduct.price} onChange={(e) => 
                          setNewProduct({...newProduct, price:e.target.value})}/>
      </div>
      <div>
        description: <input value={newProduct.description} onChange={(e) => 
                          setNewProduct({...newProduct, description:e.target.value})}/>
      </div>
      <button onClick={handleCreate}>Create</button>

      {loading?
      (<p>Loading....</p>): 
      (<div>
        <h1>Data from api</h1>
        <ul>
          {products.map(pro => (
            <li key={pro.id}>{pro.id} - {pro.name} - {pro.price} - {pro.description}</li>
          ))}
        </ul>
      
      </div>)
      }
    </div>
   
  );
}

export default App;