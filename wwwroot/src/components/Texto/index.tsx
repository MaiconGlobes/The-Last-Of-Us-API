import { SxProps, Theme, Typography } from '@mui/material';

type TProps = {
  children?: React.ReactNode;
  styles: SxProps<Theme>;
};

const Texto: React.FC<TProps> = ({ children, styles }) => {
  return <Typography sx={styles}>{children}</Typography>;
};

export default Texto;
