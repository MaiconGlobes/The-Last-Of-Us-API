import { Box, Grid, Link, Stack, useTheme } from '@mui/material';
import Divisor from '../../components/divisor';
import Texto from '../../components/texto';
import IntroductionFrame from '../../frames/docs/introduction';

const DocumentationSession = () => {
  const theme = useTheme();
  const ListaMenu = [
    {
      descricao: 'Introduction',
      link: '#',
    },
    {
      descricao: 'Authentication',
      link: '#',
    },
    {
      descricao: 'Endpoints',
      link: '#',
    },
    {
      descricao: 'API Testing',
      link: '#',
    },
  ];
  return (
    <Grid
      item
      columns={1}
      sx={{
        background: 'rgb(18 18 32)',
        position: 'relative',
        Height: '100%',
        minHeight: '75vh',
      }}>
      <Stack
        component='div'
        direction='row'
        id='documentation-session'
        sx={{
          marginX: '8vw',
        }}>
        <Stack
          sx={{
            height: '100%',
            minHeight: '75vh',
            width: '80%',
          }}>
          <Stack
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
            sx={{
              flexWrap: 'wrap',
              flexDirection: 'row',
              width: '89%',
              [theme.breakpoints.down('md')]: {
                width: '87.5%',
              },
            }}>
            <IntroductionFrame />
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
                    textTransform: 'none',
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
