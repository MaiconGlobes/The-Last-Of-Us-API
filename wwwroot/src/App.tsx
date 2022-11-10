import { Home } from '@mui/icons-material';
import { Routes, Route, BrowserRouter } from 'react-router-dom';
import HomePage from './pages/home';
import NotFoundPage from './pages/not-found';
import NotFound from './pages/not-found';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<HomePage />} />
        <Route path='*' element={<NotFoundPage />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
