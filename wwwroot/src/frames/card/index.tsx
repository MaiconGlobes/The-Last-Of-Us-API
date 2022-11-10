import { Box, useTheme } from '@mui/material';
import { Stack } from '@mui/system';

const Card = () => {
  return (
    <>
      <Stack
        sx={{
          // background: 'red',
          height: '100%',
          minHeight: '75vh',
          width: '70%',
        }}>
        {/* cards aqui */}
      </Stack>
      <Stack
        sx={{
          // background: 'yellow',
          width: '30%',
        }}>
        {/* menu categorias aqui */}
      </Stack>
    </>
  );
};

export default Card;
