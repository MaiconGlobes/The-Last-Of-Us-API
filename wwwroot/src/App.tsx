import { Home } from '@mui/icons-material';
import { Routes, Route, BrowserRouter } from 'react-router-dom';
import NotFound from './pages/not-found';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='*' element={<NotFound />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
