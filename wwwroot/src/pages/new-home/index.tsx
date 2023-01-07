import Divisor from '../../components/divisor';
import { useEffect, useState } from 'react';
import Texto from '../../components/texto';
import { AppBar, Box, Button, Grid, Skeleton, Stack, Toolbar, useTheme } from '@mui/material';
import UpdatesSession from '../../sessions/updates';
import MenuDireita from '../../frames/menu';
import Logo from '../../components/logo';

const NewHomePage = () => {
  const [imgCarregando, setImgCarregando] = useState(true);
  const theme = useTheme();

  useEffect(() => {
    setTimeout(() => {
      setImgCarregando(false);
    }, 3000);
  });

  const ImagemCapa = () => {
    return (
      <Box
        component='img'
        sx={{
          position: 'fixed',
          objectFit: 'cover',
          width: '100%',

          marginTop: {
            xs: 0,
            sm: 0,
            md: -5,
            lg: -5,
            xl: -5,
          },

          [theme.breakpoints.down('md')]: {
            height: '100%',
          },
        }}
        src='https://thelastofusapi.azurewebsites.net/img/capa-site.jpg'
        // onLoad={() => setImgCarregando(false)}
      />
    );
  };

  const TextoBoasVindas = () => {
    return (
      <>
        <Grid
          item
          columns={1}
          sx={{
            position: 'relative',
            minHeight: '100vh',
          }}>
          <Box
            component='div'
            sx={{
              height: '250px',
              width: '280px',
              margin: '100px 0 0 10vw',
            }}>
            <Box
              component='div'
              sx={{
                width: '100%',
              }}>
              <Texto
                styles={{
                  background: 'white',
                  height: '2.3rem',
                  fontSize: '2rem',
                  fontFamily: 'Compacta-bold-bt',
                  color: '#000000',
                  lineHeight: '2.5rem',
                  textAlign: 'left',
                  width: '82px',
                  paddingLeft: '3px',
                }}>
                CREATE
              </Texto>
              <Texto
                styles={{
                  fontSize: '2rem',
                  fontFamily: 'Compacta-bold-bt',
                  color: '#ffffff',
                  lineHeight: '2.5rem',
                  textAlign: 'left',
                  marginTop: '-2.29rem',
                  marginLeft: '86px',
                }}>
                AMAZING THINGS
              </Texto>
              <Texto
                styles={{
                  fontSize: '2rem',
                  fontFamily: 'Compacta-bold-bt',
                  color: '#ffffff',
                  lineHeight: '2.5rem',
                  textAlign: 'left',
                  width: '165px',
                }}>
                WITH THE BEST OF THIS API.
              </Texto>
            </Box>
            <Box
              component='div'
              sx={{
                marginTop: '10px',
                marginBottom: '10px',
                width: '100%',
              }}>
              <Texto
                styles={{
                  fontSize: '0.735rem',
                  fontFamily: 'Roboto-light',
                  color: '#e2e2e2',
                  lineHeight: '1rem',
                  textAlign: 'left',
                  width: '330px',
                }}>
                Vexor's API enables developers everywhere access
              </Texto>
              <Texto
                styles={{
                  fontSize: '0.735rem',
                  fontFamily: 'Roboto-light',
                  color: '#e2e2e2',
                  lineHeight: '1rem',
                  textAlign: 'left',
                  width: '300px',
                }}>
                information about all the characters
              </Texto>
              <Texto
                styles={{
                  fontSize: '0.735rem',
                  fontFamily: 'Roboto-light',
                  color: '#e2e2e2',
                  lineHeight: '1rem',
                  textAlign: 'left',
                  width: '300px',
                }}>
                in this amazing game.
              </Texto>
            </Box>
            <Box
              component='div'
              sx={{
                width: '100%',
              }}>
              <Button
                type='button'
                variant='contained'
                sx={{
                  background: '#C4180B',
                  border: '#7D2016 1px solid',
                  color: '#e2e2e2',
                  fontWeight: '300',
                  textAlign: 'center',
                  textTransform: 'capitalize',
                  paddingBottom: '3px',
                  height: '33px',
                  '&:active': {
                    background: '#C4180B',
                    border: '#7D2016 1px solid',
                  },
                  '&:hover': {
                    background: '#d1190c',
                    border: '#7D2016 1px solid',
                  },
                }}>
                Get Started
              </Button>
            </Box>
          </Box>
        </Grid>
      </>
    );
  };

  return (
    <>
      {imgCarregando ? (
        <>
          <Skeleton variant='rectangular' width='100vw' height='65px' animation='wave' style={{ opacity: 0.5 }} />
          <Skeleton variant='rectangular' width='100vw' height='97vh' animation='wave' style={{ opacity: 0.5 }} />
        </>
      ) : (
        <>
          <Box sx={{ flexGrow: 1 }}>
            <AppBar
              position='fixed'
              sx={{
                height: '60px',
                background: '#151111',
              }}>
              <Toolbar>
                <Logo />
                <Divisor />
                <MenuDireita />
              </Toolbar>
            </AppBar>
          </Box>
        </>
      )}
      <ImagemCapa />

      {imgCarregando ? null : (
        <>
          <TextoBoasVindas />
          <UpdatesSession />
        </>
      )}
    </>
  );
};

export default NewHomePage;
