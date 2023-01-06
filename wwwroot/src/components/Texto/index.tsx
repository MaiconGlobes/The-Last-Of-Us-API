import { useTheme } from '@emotion/react';
import { SxProps, Theme, Typography } from '@mui/material';
import React from 'react';

type TProps = {
  children?: React.ReactNode;
  styles: SxProps<Theme>;
};

const Texto: React.FC<TProps> = ({ children, styles }) => {
  // const theme = useTheme();
  return <Typography sx={styles}>{children}</Typography>;
};

export default Texto;
