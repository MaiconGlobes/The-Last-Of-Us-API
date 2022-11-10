import { Box, Link, useTheme } from '@mui/material';
import { useRef } from 'react';
import Texto from '../Texto';

const Menu = () => {
  const theme = useTheme();
  const ref = useRef(null);

  function RolarSessionCard() {
    const el = document.getElementById('session-card')?.scrollIntoView();
  }

  return (
    <>
      <Box
        sx={{
          minWidth: '114px',
          maxWidth: '116px',
          paddingBottom: '10px',
          [theme.breakpoints.down('sm')]: {
            visibility: 'hidden',
          },
        }}>
        <Texto
          styles={{
            fontFamily: 'Compacta-bold-bt',
            fontSize: '0.975rem',
            color: '#da0707',
            textDecoration: 'none',
          }}>
          DEVELOPER PORTAL |
        </Texto>
      </Box>

      <Box
        sx={{
          minWidth: '60px',
          maxWidth: '60px',
          marginX: '4px',
          paddingBottom: '10px',
        }}>
        <Link
          // href='#'
          sx={{
            fontFamily: 'Compacta-bold-bt',
            fontSize: '0.975rem',
            color: '#ffffff',
            textDecoration: 'none',
            cursor: 'pointer',
          }}
          onClick={() => RolarSessionCard()}>
          UPDATES |
        </Link>
      </Box>
      <Box
        sx={{
          minWidth: '50px',
          maxWidth: '53px',
          paddingBottom: '10px',
        }}>
        <Link
          href='/swagger/index.html'
          sx={{
            fontFamily: 'Compacta-bold-bt',
            fontSize: '0.975rem',
            color: '#ffffff',
            textDecoration: 'none',
          }}>
          SWAGGER
        </Link>
      </Box>
    </>
  );
};

export default Menu;
