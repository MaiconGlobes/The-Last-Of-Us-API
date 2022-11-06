import { Box, Button, Grid, Typography, useTheme } from '@mui/material';
import ToolBar from '../../components/appbar';

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
            src='https://images8.alphacoders.com/532/thumb-1920-532407.jpg'
            // src='../../assets/img/capa-site.jpg'
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
            component='div'
            sx={{
              // border: 'white 1px solid',
              height: '250px',
              width: '280px',
              margin: '100px 0 0 10vw',
            }}>
            <Box
              component='div'
              sx={{
                width: '100%',
              }}>
              <Typography
                sx={{
                  background: 'white',
                  height: '2.3rem',
                  fontSize: '2rem',
                  fontFamily: 'Compacta-bold-bt',
                  color: '#000000',
                  lineHeight: '2.5rem',
                  textAlign: 'left',
                  width: '82px',
                  paddingLeft: '3px',
                  // paddingTop: '0.8px',
                }}>
                CREATE
              </Typography>
              <Typography
                sx={{
                  fontSize: '2rem',
                  fontFamily: 'Compacta-bold-bt',
                  color: '#ffffff',
                  lineHeight: '2.5rem',
                  textAlign: 'left',
                  marginTop: '-2.29rem',
                  marginLeft: '86px',
                }}>
                AMAZING THINGS
              </Typography>
              <Typography
                sx={{
                  fontSize: '2rem',
                  fontFamily: 'Compacta-bold-bt',
                  color: '#ffffff',
                  lineHeight: '2.5rem',
                  textAlign: 'left',
                  width: '165px',
                }}>
                WITH THE BEST OF THIS API.
              </Typography>
            </Box>
            <Box
              component='div'
              sx={{
                // border: 'blue 0.5px solid',
                marginTop: '10px',
                marginBottom: '10px',
                width: '100%',
              }}>
              <Typography
                sx={{
                  fontSize: '0.735rem',
                  fontFamily: 'Roboto-light',
                  color: '#e2e2e2',
                  lineHeight: '1rem',
                  // fontWeight: '250',
                  textAlign: 'left',
                  width: '330px',
                }}>
                Vexor's API enables developers everywhere access
              </Typography>
              <Typography
                sx={{
                  fontSize: '0.735rem',
                  fontFamily: 'Roboto-light',
                  color: '#e2e2e2',
                  lineHeight: '1rem',
                  // fontWeight: '250',
                  textAlign: 'left',
                  width: '300px',
                }}>
                information about all the characters
              </Typography>
              <Typography
                sx={{
                  fontSize: '0.735rem',
                  fontFamily: 'Roboto-light',
                  color: '#e2e2e2',
                  lineHeight: '1rem',
                  // fontWeight: '250',
                  textAlign: 'left',
                  width: '300px',
                }}>
                in this amazing game.
              </Typography>
            </Box>
            <Box
              component='div'
              sx={{
                // border: 'red 2px solid',
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
            background: '#0E0E19',
            position: 'relative',
            minHeight: '45vh',
          }}></Grid>
        <Grid
          item
          columns={1}
          sx={{
            background: '#14141b',
            position: 'relative',
            minHeight: '200vh',
          }}></Grid>
        <Grid
          item
          columns={1}
          sx={{
            background: '#000007',
            position: 'relative',
            minHeight: '40px',
          }}></Grid>
      </Grid>
    </>
  );
};

export default HomePage;
