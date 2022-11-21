import { Grid, Stack } from '@mui/material';
import CardFrame from '../../frames/card';

const UpdatesSession = () => {
  return (
    <Grid
      item
      columns={1}
      className='card-session'
      sx={{
        background: '#0E0E19',
        position: 'relative',
        Height: '100%',
        minHeight: '75vh',
      }}>
      <Stack
        component='div'
        direction='row'
        id='session-card'
        sx={{
          marginX: '8vw',
        }}>
        <CardFrame />
      </Stack>
    </Grid>
  );
};

export default UpdatesSession;
