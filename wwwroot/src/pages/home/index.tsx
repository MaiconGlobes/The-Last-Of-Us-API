import React, { useEffect, useRef } from 'react';
import { Box, Button, Grid, Stack, Typography, useTheme } from '@mui/material';
import ToolBar from '../../frames/appbar';
import Card from '../../frames/card';
import Texto from '../../components/texto';

const HomePage = () => {
  const theme = useTheme();
  return (
    <>
      <Grid
        container
        direction='column'
        columns={12}
        sx={{
          width: '100%',
        }}>
        <Grid item columns={1}>
          <ToolBar />
        </Grid>
        <Grid
          item
          columns={9}
          sx={{
            position: 'fixed',
          }}>
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
          />
        </Grid>
        <Grid
          item
          columns={1}
          sx={{
            position: 'relative',
            minHeight: '100vh',
          }}>
          <Box
            className='presentation'
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
        <Grid
          item
          columns={1}
          sx={{
             background: 'rgb(18 18 32)',
            position: 'relative',
            Height: '100%',
            minHeight: '75vh',
          }}>
          <Stack
            component='div'
            direction='row'
            id='session-card'
            sx={{
              // background: 'green',
              marginX: '8vw',
            }}>
            <Card />
          </Stack>
        </Grid>
        <Grid
          item
          columns={1}
          className='footer'
          sx={{
            background: '#000007',
            position: 'relative',
            minHeight: '25px',
          }}>
          {/* rodape */}
        </Grid>
      </Grid>
    </>
  );
};

export default HomePage;
