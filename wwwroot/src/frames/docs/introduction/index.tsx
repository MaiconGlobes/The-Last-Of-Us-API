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
          It's easy to use the .......
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
