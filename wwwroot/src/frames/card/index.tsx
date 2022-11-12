import { Box, Button, Grid, useTheme } from '@mui/material';
import { Stack } from '@mui/system';
import Texto from '../../components/texto';

const Card = () => {
  const ListaCards = [
    {
      versao: '11.11.18',
      cateroria: 'infected',
      titulo: 'List of all types of infected in The Last of Us',
      subtitulo:
        'Lorem ipsum dolor sit amet, consectetur ur adipiscing elit consectetur adipiscing elit, sed do eiusmod. nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
      imgUrl:
        'https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgQBIZG-7CXd8TTAEn1-icOaXkBAOy_82jQARujfhK2Ou7sZW5qqSeI00oA53l547JGFhj4l-5bKdgc2qvZLTLQV8bFJX0Ir6Eb5GQ5CVGOC00jYjW0qSGfYqBH5UxxTp5ekPnzJSFhFYDZc14xiiAf9Y3jnqU26YobQ6GBeWNet3Hw4H_s1AfJvxh8dQ/s852/9218F43E-9585-4B0E-B661-E0130738BA8E.jpeg',
    },
    {
      versao: '11.11.18',
      cateroria: 'arms',
      titulo:
        'Update the listing of existing weapons and accessories in The Last of Us',
      subtitulo:
        'Lorem ipsum dolor sit amet, consectetur ur adipiscing elit consectetur adipiscing elit, sed do eiusmod. nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
      imgUrl:
        'https://www.mobygames.com/images/covers/l/538027-the-last-of-us-remastered-specter-weapon-playstation-4-front-cover.png',
    },
    {
      versao: '11.11.18',
      cateroria: 'groups',
      titulo: 'Combat group imagery implementations',
      subtitulo:
        'Lorem ipsum dolor sit amet, consectetur ur adipiscing elit consectetur adipiscing elit, sed do eiusmod. nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.',
      imgUrl:
        'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTx_7ItpX9lYrW9hKYGdrbvdZTLjWsFs8tNMw&usqp=CAU.jpg',
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
          width: '100%',
        }}>
        <Stack
          className='title-card'
          sx={{
            minHeight: '80px',
            width: '100%',
          }}>
          <Texto
            styles={{
              // background: 'black',
              fontSize: '1.25rem',
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
            // background: 'lime',
            flexWrap: 'wrap',
            flexDirection: 'row',
            width: '70%',
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
                  {element.versao}/in {element.cateroria}
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
                    maxHeight: '30%',
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
        sx={{
          // background: 'yellow',
          width: '0%',
        }}>
        {/* menu categorias aqui */}
      </Stack>
    </>
  );
};

export default Card;
