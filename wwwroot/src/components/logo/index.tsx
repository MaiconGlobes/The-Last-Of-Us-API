import { Box, useTheme } from '@mui/material';
import Texto from '../texto';

const Logo = (onLoad: any) => {
  const theme = useTheme();
  return (
    <>
      <Box
        sx={{
          flexGrow: 0,
          [theme.breakpoints.up('xs')]: {
            marginTop: '-2px',
          },
          [theme.breakpoints.up('sm')]: {
            marginTop: '-5px',
          },
          [theme.breakpoints.up('md')]: {
            marginTop: '-5px',
          },
        }}>
        <Texto
          styles={{
            fontSize: '1.2rem',
            fontFamily: 'Compacta-bold-bt',
            color: '#ffffff',
            lineHeight: '1.25rem',
            textAlign: 'left',
            height: '40px',
            width: '60px',
          }}>
          THE LAST OF US
        </Texto>
        <Texto
          styles={{
            fontSize: '22px',
            fontFamily: 'Compacta-bold-bt',
            textAlign: 'right',
            color: '#C2C2C2',
            height: '25px',
            width: '60px',
            marginLeft: '10px',
            marginTop: '-25px',
          }}>
          API
        </Texto>
      </Box>
    </>
  );
};

export default Logo;
