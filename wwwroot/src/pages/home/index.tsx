import Divisor from '../../components/divisor';
import { useEffect, useState } from 'react';
import { AppBar, Box, Toolbar } from '@mui/material';
import UpdatesSession from '../../sessions/updates';
import MenuDireita from '../../frames/menu';
import Logo from '../../frames/logo';
import ImagemCapa from '../../frames/img-capa';
import TextoBoasVindas from '../../frames/texto-boas-vindas';
import Esqueleto from '../../components/esqueleto';

const HomePage = () => {
  const [imgCarregando, setImgCarregando] = useState(true);

  useEffect(() => {
    setTimeout(() => {
      setImgCarregando(false);
    }, 3000);
  });

  return (
    <>
      {imgCarregando ? (
        <Esqueleto width='100vw' height='100vh' animation='wave' />
      ) : (
        <Box sx={{ flexGrow: 1 }}>
          <AppBar
            position='fixed'
            sx={{
              height: '60px',
              background: '#151111',
            }}>
            <Toolbar>
              <Logo />
              <Divisor />
              <MenuDireita />
            </Toolbar>
          </AppBar>
        </Box>
      )}

      <ImagemCapa />

      {imgCarregando ? null : (
        <>
          <TextoBoasVindas />
          <UpdatesSession />
        </>
      )}
    </>
  );
};

export default HomePage;
