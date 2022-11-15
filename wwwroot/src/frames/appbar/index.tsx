import { AppBar, Toolbar, useTheme } from '@mui/material';
import Divisor from '../../components/divisor';
import Logo from '../../components/logo';
import Menu from '../menu';

const ToolBar = () => {
  const theme = useTheme();
  return (
    <>
      <AppBar
        position='fixed'
        sx={{
          height: '60px',
          background: '#151111',
        }}>
        <Toolbar className='tollbar'>
          <Logo />
          <Divisor />
          <Menu />
        </Toolbar>
      </AppBar>
    </>
  );
};

export default ToolBar;
