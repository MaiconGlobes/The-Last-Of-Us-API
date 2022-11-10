import { Box, Grid, Stack, SxProps, Theme, useTheme } from '@mui/material';

type TProps = {
  children: React.ReactNode;
};

const SessionCard: React.FC<TProps> = ({ children }) => {
  return (
    <>
      <Stack
        component='div'
        direction='row'
        id='session-card'
        sx={{
          // background: 'green',
          width: '100%',
        }}>
        {children}
      </Stack>
    </>
  );
};

export default SessionCard;
