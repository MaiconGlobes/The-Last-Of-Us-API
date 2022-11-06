import {
  AppBar,
  Box,
  Grid,
  Link,
  Stack,
  Toolbar,
  Typography,
  useMediaQuery,
  useTheme,
} from '@mui/material';
import { useEffect, useState } from 'react';

const ToolBar = () => {
  const theme = useTheme();
  return (
    <>
      <AppBar position='fixed' sx={{ height: '50px', background: '#151111' }}>
        <Toolbar>
          <Box
            sx={{
              flexGrow: 0,
              [theme.breakpoints.up('xs')]: {
                marginTop: '-5px',
              },
              [theme.breakpoints.up('sm')]: {
                marginTop: '-13px',
              },
              [theme.breakpoints.up('md')]: {
                marginTop: '-15px',
              },
            }}>
            <Typography
              sx={{
                fontSize: '1.2rem',
                fontFamily: 'Compacta-bold-bt',
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
                fontFamily: 'Compacta-bold-bt',
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

          <Box sx={{ flexGrow: 2 }}></Box>

          <Box
            sx={{
              [theme.breakpoints.down('sm')]: {
                visibility: 'hidden',
              },
              minWidth: '114px',
              maxWidth: '116px',
              paddingBottom: '10px',
            }}>
            <Link
              href='#'
              sx={{
                fontFamily: 'Compacta-bold-bt',
                fontSize: '0.975rem',
                color: '#da0707',
                textDecoration: 'none',
              }}>
              DEVELOPER PORTAL |
            </Link>
          </Box>

          <Box
            sx={{
              minWidth: '42px',
              maxWidth: '45px',
              marginX: '4px',
              paddingBottom: '10px',
            }}>
            <Link
              href='#'
              sx={{
                fontFamily: 'Compacta-bold-bt',
                fontSize: '0.975rem',
                color: '#C2C2C2',
                textDecoration: 'none',
              }}>
              HOME |
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
                color: '#C2C2C2',
                textDecoration: 'none',
              }}>
              SWAGGER
            </Link>
          </Box>
        </Toolbar>
      </AppBar>
    </>
  );
};

export default ToolBar;
