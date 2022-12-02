import { Box } from '@mui/material';
import { Link } from 'react-router-dom';
import Texto from '../../../components/texto';

const IntroductionFrame = () => {
  return (
    <>
      <Box>
        <Texto
          styles={{
            fontSize: '1.2rem',
            fontFamily: 'Roboto-regular',
            fontWeight: '400',
            color: '#e2e2e2',
            lineHeight: '1.8rem',
            textAlign: 'left',
            padding: '0 0 0 1%',
            marginBottom: '20px',
          }}>
          Overview
        </Texto>
        <Texto
          styles={{
            fontSize: '0.9rem',
            fontFamily: 'Roboto-light',
            fontWeight: '100',
            color: '#bbbbbb',
            textTransform: 'none',
            padding: '0 5% 3% 1%',
          }}>
          Welcome to the world's largest API hub.
          <br />
          <br />
          Find what you need for your project, embed the API in your application
          and make the most of the perfect story of one of the best games ever
          released. If you create a website and/or APP, use the API to make it
          available to thousands of fans worldwide.
          <br />
          It's easy to use the API to consume applications. With The Last Of Us
          API you can consume any route using a unified format that is easy to
          understand and incorporate into your application. To learn more about
          using APIs, check out our{' '}
          <Link to='/swagger/index.html' className='link-swagger'>
            Swagger
          </Link>
          Request Guide or our developer documentation page.
        </Texto>
        <Texto
          styles={{
            fontSize: '1.2rem',
            fontFamily: 'Roboto-regular',
            fontWeight: '400',
            color: '#e2e2e2',
            lineHeight: '1.8rem',
            textAlign: 'left',
            padding: '0 0 0 1%',
            marginBottom: '20px',
          }}>
          Developer Quick Start Guide
        </Texto>
        <Texto
          styles={{
            fontSize: '0.9rem',
            fontFamily: 'Roboto-light',
            fontWeight: '100',
            color: '#bbbbbb',
            textTransform: 'none',
            padding: '0 5% 3% 1%',
          }}>
          Learn how to use the TLOU API to make your first API call and quickly
          integrate into your app.
          <br />
          The first thing you'll want to do is locate an API that you want to
          use. Let's find a translation API for this example. To get started,
          you can type "translation" into the search bar, which will return top
          results for your search term.
        </Texto>
        <Box
          id='developer-quick-session'
          component='img'
          sx={{
            objectFit: 'fill',
            height: '35vw',
            width: '100%',
          }}
          src='https://thelastofusapi.azurewebsites.net/img/insomnia/app01-min.gif'
        />
      </Box>
    </>
  );
};

export default IntroductionFrame;
