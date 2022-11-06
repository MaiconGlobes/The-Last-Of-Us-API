import { Box, Grid, Typography, useTheme } from '@mui/material';
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
                  fontSize: '2rem',
                  fontFamily: 'compacta-bold-bt',
                  color: '#000000',
                  lineHeight: '2.5rem',
                  textAlign: 'left',
                  width: '82px',
                  paddingLeft: '3px',
                  paddingTop: '1.5px',
                }}>
                CREATE
              </Typography>
              <Typography
                sx={{
                  fontSize: '2rem',
                  fontFamily: 'compacta-bold-bt',
                  color: '#ffffff',
                  lineHeight: '2.5rem',
                  textAlign: 'left',
                  marginTop: '-2.5rem',
                  marginLeft: '86px',
                }}>
                AMAZING THINGS
              </Typography>
              <Typography
                sx={{
                  fontSize: '2rem',
                  fontFamily: 'compacta-bold-bt',
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
                width: '100%',
              }}>
              <Typography
                sx={{
                  fontSize: '0.85rem',
                  fontFamily: 'Roboto',
                  color: '#e2e2e2',
                  lineHeight: '1rem',
                  fontWeight: '280',
                  textAlign: 'left',
                  width: '305px',
                }}>
                Vexor's API enables developers everywhere access
              </Typography>
              <Typography
                sx={{
                  fontSize: '0.85rem',
                  fontFamily: 'Roboto',
                  color: '#e2e2e2',
                  lineHeight: '1rem',
                  fontWeight: '280',
                  textAlign: 'left',
                  width: '300px',
                }}>
                information about all the characters
              </Typography>
              <Typography
                sx={{
                  fontSize: '0.85rem',
                  fontFamily: 'Roboto',
                  color: '#e2e2e2',
                  lineHeight: '1rem',
                  fontWeight: '280',
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
              3
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
