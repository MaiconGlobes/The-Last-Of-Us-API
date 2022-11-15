import { Box, Button, Grid, Link, useTheme } from '@mui/material';
import { Stack } from '@mui/system';
import Divisor from '../../components/divisor';
import Texto from '../../components/texto';

const Card = () => {
  const theme = useTheme();
  const ListaCards = [
    {
      versao: '11.11.18',
      cateroria: 'infected',
      titulo: 'List of all types of infected in The Last of Us',
      subtitulo:
        'Lorem ipsum dolor sit amet, consectetur ur adipiscing elit consectetur adipiscing elit, sed do eiusmod. nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
      imgUrl: 'https://thelastofusapi.azurewebsites.net/img/card/infected.jpeg',
    },
    {
      versao: '11.11.17',
      cateroria: 'arms',
      titulo:
        'Update the listing of existing weapons and accessories in The Last of Us',
      subtitulo:
        'Lorem ipsum dolor sit amet, consectetur ur adipiscing elit consectetur adipiscing elit, sed do eiusmod. nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
      imgUrl: 'https://thelastofusapi.azurewebsites.net/img/card/arms.jpeg',
    },
    {
      versao: '11.11.16',
      cateroria: 'groups',
      titulo: 'Combat group imagery implementations',
      subtitulo:
        'Lorem ipsum dolor sit amet, consectetur ur adipiscing elit consectetur adipiscing elit, sed do eiusmod. nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
      imgUrl: 'https://thelastofusapi.azurewebsites.net/img/card/groups.jpeg',
    },
  ];

  const ListaMenu = [
    {
      descricao: 'Last Update',
      link: '#',
    },
    {
       descricao: 'Development curiosities',
      link: '#',
    },
    {
       descricao: 'Tools',
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
          className='title-card'
          sx={{
            minHeight: '80px',
            width: '100%',
            marginBottom: '20px',
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
              marginTop: '10px',
            }}>
            Last updates
          </Texto>
        </Stack>

        <Stack
          className='body-card-item'
          sx={{
            flexWrap: 'wrap',
            flexDirection: 'row',
            [theme.breakpoints.down('md')]: {
              width: '100%',
            },
          }}>
          {ListaCards.map((element) => (
            <>
              <Stack
                className='img-card'
                sx={{
                  // background: 'red',
                  marginBottom: '50px',
                }}>
                <Box
                  component='img'
                  sx={{
                    objectFit: 'cover',
                    height: '18vw',
                    width: '18vw',
                  }}
                  src={element.imgUrl}
                />
              </Stack>
              <Stack
                className='infos-card'
                sx={{
                  // background: 'blue',
                  margin: '0 0 50px 15px',
                  width: '60%',
                }}>
                <Texto
                  styles={{
                    fontSize: '0.875rem',
                    fontFamily: 'Roboto-regular',
                    fontWeight: '300',
                    color: '#e2e2e2',
                    lineHeight: '1rem',
                    textAlign: 'left',
                    marginBottom: '20px',
                    width: '300px',
                  }}>
                  {element.versao} in /{element.cateroria}
                </Texto>
                <Texto
                  styles={{
                    fontSize: '1.4rem',
                    fontFamily: 'Roboto-regular',
                    fontWeight: '400',
                    color: '#e2e2e2',
                    lineHeight: '1.8rem',
                    textAlign: 'left',
                    marginBottom: '20px',
                    // width: '300px',
                  }}>
                  {element.titulo}
                </Texto>
                <Texto
                  styles={{
                    fontSize: '0.75rem',
                    fontFamily: 'Roboto-light',
                    fontWeight: '200',
                    color: '#b1b1b1',
                    lineHeight: '1rem',
                    textAlign: 'left',
                    marginBottom: '20px',
                    minHeight: '30%',
                    [theme.breakpoints.up('sm')]: {
                      maxHeight: '40%',
                    },
                  }}>
                  {element.subtitulo}
                </Texto>
                <Button
                  type='button'
                  variant='contained'
                  sx={{
                    background: '#C4180B',
                    border: '#bd1408 1px solid',
                    color: '#e2e2e2',
                    fontWeight: '100',
                    textAlign: 'center',
                    textTransform: 'capitalize',
                    paddingBottom: '3px',
                    height: '30px',
                    width: '120px',
                    cursor: 'no-drop',
                    '&:active': {
                      background: '#C4180B',
                      border: '#bd1408 1px solid',
                    },
                    '&:hover': {
                      background: '#d1190c',
                      border: '#bd1408 1px solid',
                    },
                  }}>
                  Read more
                </Button>
              </Stack>
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
            background: '#1b1b2a',
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
                  // background: 'green',
                }}>
                {element.descricao}
              </Link>
              <Divisor />
            </>
          ))}
        </Box>
        <Box
          component='div'
          sx={{
            background: '#1b1b2a',
            borderRadius: '3px',
            minHeight: '60%',
            padding: '0 0 0 15px',
          }}>
          <Texto
            styles={{
              // background: 'black',
              fontSize: '1rem',
              fontFamily: 'Roboto-regular',
              fontWeight: '500',
              color: '#ffffff',
              textTransform: 'uppercase',
              marginTop: '10px',
            }}>
            Othres
          </Texto>
          {/* menu categorias aqui */}
        </Box>
      </Stack>
    </>
  );
};

export default Card;
