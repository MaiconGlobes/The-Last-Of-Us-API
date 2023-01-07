import Divisor from '../../components/divisor';
import { useContext, useEffect, useState } from 'react';
import UpdatesSession from '../../sessions/updates';
import MenuDireita from '../../frames/menu';
import Logo from '../../frames/logo';
import ImagemCapa from '../../frames/img-capa';
import TextoBoasVindas from '../../frames/texto-boas-vindas';
import Esqueleto from '../../components/esqueleto';
import ToolBarApp from '../../components/toolbar';
import { Box } from '@mui/material';
import { ContextoCarregamento } from '../../context';

const HomePage = () => {
  const { isImgCarregando, setImgCarregando } = useContext(ContextoCarregamento);

  //Usado para testes
  // useEffect(() => {
  //   setTimeout(() => {
  //     setImgCarregando(false);
  //   }, 3000);
  // });

  const estiloToolBarApp = {
    height: '60px',
    background: '#151111',
  };

  return (
    <>
      {isImgCarregando ? (
        <Esqueleto width='100vw' height='100vh' animation='wave' />
      ) : (
        <Box sx={{ flexGrow: 1 }}>
          <ToolBarApp styles={estiloToolBarApp}>
            <Logo />
            <Divisor />
            <MenuDireita />
          </ToolBarApp>
        </Box>
      )}

      <ImagemCapa />

      {isImgCarregando ? null : (
        <>
          <TextoBoasVindas />
          <UpdatesSession />
        </>
      )}
    </>
  );
};

export default HomePage;
