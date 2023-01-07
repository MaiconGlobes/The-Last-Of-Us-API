import { AppBar, SxProps, Theme, Toolbar } from '@mui/material';

type TProps = {
  children?: React.ReactNode;
  styles: SxProps<Theme>;
};

const ToolBarApp: React.FC<TProps> = ({ children, styles }) => {
  return (
    <AppBar position='fixed' sx={styles}>
      <Toolbar>{children}</Toolbar>
    </AppBar>
  );
};

export default ToolBarApp;
