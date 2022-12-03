import { Avatar, Box, Chip } from '@mui/material';
import Divisor from '../../../components/divisor';
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
          Welcome to The Last Of Us Public API.
          <br />
          <br />
          The REST API is used to access and manipulate data related to all
          entities in The Last Of US game. It is designed to provide a standard
          set of CRUD actions for most entities: create, read, update, and
          delete.
          <br />
          For reasons of data integrity and reliability, inserting, editing and
          deleting entities has been limited to project developers only.
          <br />
          <br />
          Using the API you can do things like:
          <br />- List data related to the game such as release date, mission,
          synopsis, supported consoles and more.
          <br />- Lists the most striking phrases and quotes in the game. This
          includes only phrases spoken by the characters, with no dialogue
          between them.
          <br />- List the weapons and accessories used in the game. It is
          possible to list by characters.
          <br />- List all characters in the game, along with information
          related to them, such as function, importance, date of death, among
          others.
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
          It's very easy to use the TLOU API. Just enter the URI and make the
          request via REST.
          <br />
          <br />
          The returned pattern consists of a JSON (JavaScript Object Notation)
          architecture model. It is recommended to use applications to carry out
          the requests.
          <br />
          We recommend using Imsomnia as shown in the image below.
        </Texto>

        <Box
          id='start-guide-session'
          component='img'
          sx={{
            objectFit: 'fill',
            height: '35vw',
            width: '100%',
            marginBottom: '30px',
          }}
          src='https://thelastofusapi.azurewebsites.net/img/insomnia/app01-min.gif'
        />
      </Box>

      <Box id='http-request-headers' component='div'>
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
          The following headers should be set as applicable when making HTTP
          requests to the REST API:
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
          <Chip label='Content-Type:' variant='outlined' size='small' />
          &nbsp;required when making a or request. The MIME media type should be
          GET application/json.
          <br />
          <Chip label='Authorization:' variant='outlined' size='small' />
          &nbsp;required for all requests; see Authentication.
        </Texto>
        <Box
          id='header-config-session'
          component='img'
          sx={{
            objectFit: 'fill',
            height: '35vw',
            width: '100%',
            marginBottom: '30px',
          }}
          src='https://thelastofusapi.azurewebsites.net/img/insomnia/header-config.gif'
        />
      </Box>
    </>
  );
};

export default IntroductionFrame;
