import { AppBar, Toolbar } from '@mui/material';
import Divisor from '../divisor';
import Logo from '../logo';
import Menu from '../menu';

const ToolBar = () => {
  return (
    <>
      <AppBar
        position='fixed'
        sx={{
          height: '50px',
          background: '#151111',
        }}>
        <Toolbar>
          <Logo />
          <Divisor />
          <Menu />
        </Toolbar>
      </AppBar>
    </>
  );
};

export default ToolBar;
