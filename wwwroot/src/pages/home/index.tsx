import { Box, Grid, useTheme } from '@mui/material';
import ToolBar from '../../components/appbar';

const HomePage = () => {
  const theme = useTheme();
  return (
    <>
      <Grid
        className='container'
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
          className='body-main'
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
              height: '50vh',
              width: '30vw',
              margin: '100px 0 0 80px',
            }}
          />
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
