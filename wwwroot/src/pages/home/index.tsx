import { Grid } from '@mui/material';
import UpdatesSession from '../../sessions/updates';
import IntroductionSession from '../../sessions/introduction';
import HeaderSession from '../../sessions/header';
import FooterSession from '../../sessions/footer';
import DocumentationSession from '../../sessions/documentation';

const HomePage = () => {
  return (
    <>
      <Grid
        container
        direction='column'
        columns={12}
        sx={{
          width: '100%',
        }}>
        <HeaderSession />
        <IntroductionSession />
        <UpdatesSession />
        <DocumentationSession />
        <FooterSession />
      </Grid>
    </>
  );
};

export default HomePage;
