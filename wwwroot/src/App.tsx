import React from 'react';
import { Routes, Route, BrowserRouter } from 'react-router-dom';

const Home = () => {
  return <>Eu to aqui agora</>;
};

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='*' element={<>Deu ruim</>} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
