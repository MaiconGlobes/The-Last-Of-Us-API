import { Grid, Stack } from '@mui/material';
import DocumentationFrame from '../../frames/documentation';

const DocumentationSession = () => {
  return (
    <Grid
      item
      columns={1}
      className='documentation-session'
      sx={{
        background: 'rgb(18 18 32)',
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
        <DocumentationFrame />
      </Stack>
    </Grid>
  );
};

export default DocumentationSession;
