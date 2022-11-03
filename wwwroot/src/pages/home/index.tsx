import {
  AppBar,
  Box,
  Button,
  Container,
  Grid,
  IconButton,
  ImageList,
  ImageListItem,
  Paper,
  styled,
  Toolbar,
  Typography,
  useTheme,
} from '@mui/material';

const itemData = [
  {
    img: 'https://images8.alphacoders.com/532/thumb-1920-532407.jpg',
    title: 'Breakfast',
  },
];

const HomePage = () => {
  const theme = useTheme();
  return (
    <>
      <Grid
        className='container'
        container
        direction='column'
        justifyContent='space-between'
        alignItems='stretch'
        columns={12}
        sx={{
          background: 'gray',
          width: '100%',
        }}>
        <Grid
          className='header'
          item
          xs={1}
          sm={1}
          md={1}
          lg={1}
          xl={1}
          sx={{
            background: 'red',
          }}>
          <AppBar position='static' sx={{ height: '50px' }}>
            <Toolbar>
              <Box
                sx={{
                  flexGrow: 0,
                  [theme.breakpoints.up('xs')]: {
                    // background: 'red',
                    marginTop: '-5px',
                  },
                  [theme.breakpoints.up('sm')]: {
                    // background: 'blue',
                    marginTop: '-13px',
                  },
                  [theme.breakpoints.up('md')]: {
                    // background: 'orange',
                    marginTop: '-15px',
                  },
                }}>
                <Typography
                  sx={{
                    // background: 'red',
                    fontSize: '1.2rem',
                    fontFamily: 'compacta-bold-bt',
                    color: '#ffffff',
                    lineHeight: '1.25rem',
                    textAlign: 'left',
                    height: '40px',
                    width: '60px',
                  }}>
                  THE LAST OF US
                </Typography>
                <Typography
                  fontSize={22}
                  sx={{
                    // background: 'green',
                    fontFamily: 'compacta-bold-bt',
                    textAlign: 'right',
                    color: '#C2C2C2',
                    height: '25px',
                    width: '60px',
                    marginLeft: '10px',
                    marginTop: '-25px',
                  }}>
                  API
                </Typography>
              </Box>
              {/* <Box sx={{ flexGrow: 3, background: 'white' }}>ss</Box> */}
              {/* <Box sx={{ flexGrow: 1, background: 'blue' }}>ss</Box> */}
            </Toolbar>
          </AppBar>
        </Grid>
        {/* <Grid
          className='body-main'
          item
          xs={9}
          sm={9}
          md={9}
          lg={9}
          xl={9}
          sx={{
            background: 'blue',
            // minHeight: '500px',
          }}>
          body
        </Grid>
        <Grid
          className='footer'
          item
          xs={2}
          sm={2}
          md={2}
          lg={2}
          xl={2}
          sx={{
            background: 'lime',
          }}>
          Rodapé
        </Grid> */}
      </Grid>
    </>
  );
};

export default HomePage;
