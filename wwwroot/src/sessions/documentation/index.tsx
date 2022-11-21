import { Box, Grid, Link, Stack, useTheme } from '@mui/material';
import Divisor from '../../components/divisor';
import Texto from '../../components/texto';
import AuthenticationFrame from '../../frames/doc-authentication';
import IntroductionFrame from '../../frames/doc-introduction';
import VersioningFrame from '../../frames/doc-versioning';

const DocumentationSession = () => {
  const theme = useTheme();
  const ListaMenu = [
    {
      descricao: 'Introduction',
      link: '#introduction-summary',
    },
    {
      descricao: 'Authentication',
      link: '#authentication-summary',
    },
    {
      descricao: 'Versioning',
      link: '#versioning-summary',
    },
    {
      descricao: 'Endpoints',
      link: '#endpoints-summary',
    },
    {
      descricao: 'Pagination',
      link: '#pagination-summary',
    },
  ];
  return (
    <Grid
      item
      columns={1}
      className='documentation-session'
      sx={{
        background: '#1b1b2a',
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
        <Stack
          className='body-card-main'
          sx={{
            height: '100%',
            minHeight: '75vh',
            width: '80%',
          }}>
          <Stack
            className='documentation-card'
            sx={{
              minHeight: '80px',
              width: '100%',
              marginBottom: '25px',
            }}>
            <Texto
              styles={{
                fontSize: '1.28rem',
                fontFamily: 'Roboto-regular',
                fontWeight: '550',
                color: '#e2e2e2',
                textAlign: 'left',
                textTransform: 'uppercase',
                marginTop: '20px',
              }}>
              Documentation
            </Texto>
          </Stack>

          <Stack
            className='body-documentation-item'
            sx={{
              flexWrap: 'wrap',
              flexDirection: 'row',
              [theme.breakpoints.down('md')]: {
                width: '100%',
              },
            }}>
            <IntroductionFrame />
            <AuthenticationFrame />
            <VersioningFrame />
          </Stack>
        </Stack>
        <Stack
          spacing={2}
          sx={{
            width: '20%',
            justifyContent: 'stretch',
            alignContent: 'center',
            padding: ' 100px 15px 0 15px',
            textAlign: 'left',
            [theme.breakpoints.down('md')]: {
              visibility: 'hidden',
              width: '0%',
            },
          }}>
          <Box
            component='div'
            sx={{
              background: '#181826',
              borderLeft: '1.5px solid #919191',
              borderRadius: '3px',
              minHeight: '20%',
              padding: '0 0 10px 15px',
            }}>
            <Texto
              styles={{
                fontSize: '1rem',
                fontFamily: 'Roboto-regular',
                fontWeight: '500',
                color: '#ffffff',
                textTransform: 'uppercase',
                margin: '10px 0 10px 0',
              }}>
              Summary
            </Texto>
            {ListaMenu.map((element) => (
              <>
                <Link
                  href={element.link}
                  sx={{
                    fontSize: '0.875rem',
                    fontFamily: 'Roboto-regular',
                    color: '#bbbbbb',
                    textTransform: 'capitalize',
                    textDecoration: 'none',
                    paddingLeft: '5px',
                    cursor: 'pointer',
                    '&:hover': {
                      fontSize: '0.9rem',
                      textDecoration: 'underline',
                    },
                  }}>
                  {element.descricao}
                </Link>
                <Divisor />
              </>
            ))}
          </Box>
        </Stack>
      </Stack>
    </Grid>
  );
};

export default DocumentationSession;
