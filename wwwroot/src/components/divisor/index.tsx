import { Box, useTheme } from '@mui/material';
import Texto from '../texto';

const Divisor = () => {
  const theme = useTheme();
  return <Box sx={{ flexGrow: 2 }}></Box>;
};

export default Divisor;