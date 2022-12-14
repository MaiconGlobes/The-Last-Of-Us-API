import { Box, Button, Grid, Link, useTheme } from '@mui/material';
import { Stack } from '@mui/system';
import Divisor from '../../components/divisor';
import Texto from '../../components/texto';

const DocumentationFrame = () => {
  const theme = useTheme();
  const Paragrafo = () => {
    return <br></br>;
  };
  const ListaConteudo = [
    {
      titulo: 'Introduction',
      descricao: `Lorem Ipsum is simply dummy text of the printing and typesetting industry.
        Lorem Ipsum has been the industrys standard dummy text ever since the 1500s, when an unknown printer took a galley of type 
        and scrambled it to make a type specimen book. It has survived not only five centuries, 
        but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release 
        of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.`,
    },
    {
      titulo: 'REST API',
      descricao: `Lorem Ipsum is simply dummy text of the printing and typesetting
      industry. Lorem Ipsum has been the industrys standard dummy text ever
      since the 1500s, when an unknown printer took a galley of type and
      scrambled it to make a type specimen book. It has survived not only
      five centuries, but also the leap into electronic typesetting,
      remaining essentially unchanged. It was popularised in the 1960s with
      the release of Letraset sheets containing Lorem Ipsum passages, and
      more recently with desktop publishing software like Aldus PageMaker
      including versions of Lorem Ipsum. Lorem Ipsum is simply dummy text of
      the printing and typesetting industry.
      Lorem Ipsum is simply dummy text of the printing and typesetting
      industry. Lorem Ipsum has been the industrys standard dummy text ever
      since the 1500s, when an unknown printer took a galley of type and
      scrambled it to make a type specimen book. It has survived not only
      five centuries, but also the leap into electronic typesetting,
      remaining essentially unchanged. It was popularised in the 1960s with
      the release of Letraset sheets containing Lorem Ipsum passages, and
      more recently with desktop publishing software like Aldus PageMaker
      including versions of Lorem Ipsum. Lorem Ipsum is simply dummy text of
      the printing and typesetting industry.`,
    },
    {
      titulo: 'Authentication',
      descricao: `Lorem Ipsum is simply dummy text of the printing and typesetting
      industry. Lorem Ipsum has been the industrys standard dummy text ever
      since the 1500s, when an unknown printer took a galley of type and
      scrambled it to make a type specimen book. It has survived not only
      five centuries, but also the leap into electronic typesetting,
      remaining essentially unchanged. It was popularised in the 1960s with
      the release of Letraset sheets containing Lorem Ipsum passages, and
      more recently with desktop publishing software like Aldus PageMaker
      including versions of Lorem Ipsum. Lorem Ipsum is simply dummy text of
      the printing and typesetting industry.
      Lorem Ipsum is simply dummy text of the printing and typesetting
      industry. Lorem Ipsum has been the industrys standard dummy text ever
      since the 1500s, when an unknown printer took a galley of type and
      scrambled it to make a type specimen book. It has survived not only
      five centuries, but also the leap into electronic typesetting,
      remaining essentially unchanged. It was popularised in the 1960s with
      the release of Letraset sheets containing Lorem Ipsum passages, and
      more recently with desktop publishing software like Aldus PageMaker
      including versions of Lorem Ipsum. Lorem Ipsum is simply dummy text of
      the printing and typesetting industry.`,
    },
    {
      titulo: 'Versioning',
      descricao: `Lorem Ipsum is simply dummy text of the printing and typesetting
      industry. Lorem Ipsum has been the industrys standard dummy text ever
      since the 1500s, when an unknown printer took a galley of type and
      scrambled it to make a type specimen book. It has survived not only
      five centuries, but also the leap into electronic typesetting,
      remaining essentially unchanged. It was popularised in the 1960s with
      the release of Letraset sheets containing Lorem Ipsum passages, and
      more recently with desktop publishing software like Aldus PageMaker
      including versions of Lorem Ipsum. Lorem Ipsum is simply dummy text of
      the printing and typesetting industry.
      Lorem Ipsum is simply dummy text of the printing and typesetting
      industry. Lorem Ipsum has been the industrys standard dummy text ever
      since the 1500s, when an unknown printer took a galley of type and
      scrambled it to make a type specimen book. It has survived not only
      five centuries, but also the leap into electronic typesetting,
      remaining essentially unchanged. It was popularised in the 1960s with
      the release of Letraset sheets containing Lorem Ipsum passages, and
      more recently with desktop publishing software like Aldus PageMaker
      including versions of Lorem Ipsum. Lorem Ipsum is simply dummy text of
      the printing and typesetting industry.`,
    },
    {
      titulo: 'Endpoints',
      descricao: `Lorem Ipsum is simply dummy text of the printing and typesetting
      industry. Lorem Ipsum has been the industrys standard dummy text ever
      since the 1500s, when an unknown printer took a galley of type and
      scrambled it to make a type specimen book. It has survived not only
      five centuries, but also the leap into electronic typesetting,
      remaining essentially unchanged. It was popularised in the 1960s with
      the release of Letraset sheets containing Lorem Ipsum passages, and
      more recently with desktop publishing software like Aldus PageMaker
      including versions of Lorem Ipsum. Lorem Ipsum is simply dummy text of
      the printing and typesetting industry.
      Lorem Ipsum is simply dummy text of the printing and typesetting
      industry. Lorem Ipsum has been the industrys standard dummy text ever
      since the 1500s, when an unknown printer took a galley of type and
      scrambled it to make a type specimen book. It has survived not only
      five centuries, but also the leap into electronic typesetting,
      remaining essentially unchanged. It was popularised in the 1960s with
      the release of Letraset sheets containing Lorem Ipsum passages, and
      more recently with desktop publishing software like Aldus PageMaker
      including versions of Lorem Ipsum. Lorem Ipsum is simply dummy text of
      the printing and typesetting industry.`,
    },
    {
      titulo: 'Lorem Ipsum',
      descricao: `Lorem Ipsum is simply dummy text of the printing and typesetting
      industry. Lorem Ipsum has been the industrys standard dummy text ever
      since the 1500s, when an unknown printer took a galley of type and
      scrambled it to make a type specimen book. It has survived not only
      five centuries, but also the leap into electronic typesetting,
      remaining essentially unchanged. It was popularised in the 1960s with
      the release of Letraset sheets containing Lorem Ipsum passages, and
      more recently with desktop publishing software like Aldus PageMaker
      including versions of Lorem Ipsum. Lorem Ipsum is simply dummy text of
      the printing and typesetting industry.
      Lorem Ipsum is simply dummy text of the printing and typesetting
      industry. Lorem Ipsum has been the industrys standard dummy text ever
      since the 1500s, when an unknown printer took a galley of type and
      scrambled it to make a type specimen book. It has survived not only
      five centuries, but also the leap into electronic typesetting,
      remaining essentially unchanged. It was popularised in the 1960s with
      the release of Letraset sheets containing Lorem Ipsum passages, and
      more recently with desktop publishing software like Aldus PageMaker
      including versions of Lorem Ipsum. Lorem Ipsum is simply dummy text of
      the printing and typesetting industry.`,
    },
  ];

  const ListaMenu = [
    {
      descricao: 'Introduction',
      link: '#',
    },
    {
      descricao: 'REST API',
      link: '#',
    },
    {
      descricao: 'Authentication',
      link: '#',
    },
    {
      descricao: 'Versioning',
      link: '#',
    },
    {
      descricao: 'Endpoints',
      link: '#',
    },
    {
      descricao: 'Pagination',
      link: '#',
    },
  ];

  return (
    <>
      <Stack
        className='body-card-main'
        sx={{
          // background: '#727272',
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
              // background: 'black',
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
            // background: 'red',
            flexWrap: 'wrap',
            flexDirection: 'row',
            width: '90%',
            [theme.breakpoints.down('md')]: {},
          }}>
          {ListaConteudo.map((element) => (
            <>
              <Texto
                styles={{
                  fontSize: '1.4rem',
                  fontFamily: 'Roboto-regular',
                  fontWeight: '400',
                  color: '#e2e2e2',
                  lineHeight: '1.8rem',
                  textAlign: 'left',
                  marginBottom: '20px',
                }}>
                {element.titulo}
              </Texto>
              <Texto
                styles={{
                  fontSize: '0.75rem',
                  fontFamily: 'Roboto-light',
                  fontWeight: '100',
                  color: '#b1b1b1',
                  lineHeight: '1rem',
                  textAlign: 'left',
                  marginBottom: '20px',
                }}>
                {element.descricao}
              </Texto>
            </>
          ))}
        </Stack>
      </Stack>
      <Stack
        spacing={2}
        sx={{
          // background: 'gray',
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
              // background: 'black',
              fontSize: '1rem',
              fontFamily: 'Roboto-regular',
              fontWeight: '500',
              color: '#ffffff',
              textTransform: 'uppercase',
              margin: '10px 0 10px 0',
            }}>
            Categories
          </Texto>
          {ListaMenu.map((element) => (
            <>
              <Link
                href='#'
                sx={{
                  fontSize: '0.875rem',
                  fontFamily: 'Roboto-regular',
                  color: '#9b9b9b',
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
    </>
  );
};

export default DocumentationFrame;
