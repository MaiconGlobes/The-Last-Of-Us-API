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
          The REST API is used to access and manipulate data related to all entities in The Last Of Us game.
          <br />
          It is designed to provide standard CRUD actions for most entities: create, read, update and delete, but for reasons of data integrity and reliability
          the methods of inserting, editing, deleting entities has been limited to project developers only.
          <br />
          <br />
          Using the API you can do things like:
          <br />- Get game related data like release date, mission, synopsis, supported consoles and more.
          <br />- List the most striking phrases and quotes in the game. This only includes phrases spoken by the characters, limited to dialogue between them.
          <br />- List weapons and accessories used in the game, being possible to obtain them by specific characters.
          <br />- List data of all characters in the game, along with information related to each one, such as function, importance, among others.
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
          It's very easy to use the TLOU API. Just enter the URI and make the request via REST.
          <br />
          <br />
          The returned pattern consists of a JSON (JavaScript Object Notation) architecture model. It is recommended to use applications to carry out the
          requests.
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
          Headers for HTTP requests
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
          The following headers should be set as applicable when making HTTP requests to the REST API:
          <br />
          <Chip label='Content-Type:' variant='outlined' size='small' />
          &nbsp;required when making a or request. The MIME media type should be GET application/json.
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
          Types
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
          <Chip label='ID:' variant='outlined' size='small' />
          &nbsp;IDs are represented in the TLOU API as strings. All IDs will be contained in a key.id These IDs are not globally unique, but will be unique
          within a given endpoint. For example, a character in a database table will have an id, but no two characters have the same id.
          <br />
          <Chip label='UUID:' variant='outlined' size='small' />
          &nbsp;Uuid fields are designated with the presence of in your key name and contain string ID values.uuid UUIDs can be considered unique across the
          TLOU, that is, no two resources of any type repeat the same UUID.
          <br />
          <Chip label='String:' variant='outlined' size='small' />
          &nbsp;A standard JSON string. Strings in the REST API use the UTF-8 character set.
          <br />
          <Chip label='Integer:' variant='outlined' size='small' />
          &nbsp;Integer types are a number that can have a fractional or decimal component.
          <br />
          <Chip label='Boolean:' variant='outlined' size='small' />
          &nbsp;A boolean has only two possible states: true and false. In responses, booleans are always represented by native JSON booleans — or without
          quotes.truefalse In query strings, booleans can also be represented by string values. and are acceptable to represent a truthy value, and and are
          acceptable to represent a falsy value."1""true""0""false"
          <br />
          <Chip label='Array:' variant='outlined' size='small' />
          &nbsp;A standard JSON array. Arrays can contain any number of values, and their values ​​are alphanumeric.
          <br />
          <Chip label='Object:' variant='outlined' size='small' />
          &nbsp;A standard JSON object. Objects consist of string keys paired with values that may be of any type.
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
