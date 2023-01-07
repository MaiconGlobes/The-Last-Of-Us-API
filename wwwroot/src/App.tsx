import { Routes, Route, BrowserRouter } from 'react-router-dom';
import { CarregamentoImgProvider } from './context';
import HomePage from './pages/home';
import NotFoundPage from './pages/not-found';

function App() {
  return (
    <>
      <CarregamentoImgProvider>
        <BrowserRouter>
          <Routes>
            <Route path='*' element={<HomePage />} />
            <Route path='*' element={<NotFoundPage />} />
          </Routes>
        </BrowserRouter>
      </CarregamentoImgProvider>
    </>
  );
}

export default App;
