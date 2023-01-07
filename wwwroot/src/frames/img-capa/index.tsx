import { Box, useTheme } from '@mui/material';

const ImagemCapa = () => {
  const theme = useTheme();

  return (
    <Box
      component='img'
      sx={{
        position: 'fixed',
        objectFit: 'cover',
        width: '100%',
        marginTop: {
          xs: 0,
          sm: 0,
          md: -5,
          lg: -5,
          xl: -5,
        },

        [theme.breakpoints.down('md')]: {
          height: '100%',
        },
      }}
      src='https://thelastofusapi.azurewebsites.net/img/capa-site.jpg'
      // onLoad={() => setImgCarregando(false)}
    />
  );
};

export default ImagemCapa;
