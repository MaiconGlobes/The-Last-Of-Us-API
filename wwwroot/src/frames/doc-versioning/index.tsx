import { Box } from '@mui/material';
import Texto from '../../components/texto';

const VersioningFrame = () => {
  return (
    <>
      <Box className='introduction-summary'>
        <Texto
          styles={{
            fontSize: '1.2rem',
            fontFamily: 'Roboto-regular',
            fontWeight: '500',
            color: '#ffffff',
            textTransform: 'none',
            padding: '0 5% 0 1%',
            margin: '0 0 10px 0',
          }}>
          Versioning
        </Texto>
        <Texto
          styles={{
            fontSize: '0.875rem',
            fontFamily: 'Roboto-light',
            fontWeight: '100',
            color: '#bbbbbb',
            textTransform: 'none',
            padding: '0 5% 3% 1%',
          }}>
          There are many variations of passages of Lorem Ipsum available, but
          the majority have suffered alteration in some form, by injected
          humour, or randomised words which don't look even slightly believable.
          If you are going to use a passage of Lorem Ipsum, you need to be sure
          there isn't anything embarrassing hidden in the middle of text. All
          the Lorem Ipsum generators on the Internet tend to repeat predefined
          chunks as necessary, making this the first true generator on the
          Internet. It uses a dictionary of over 200 Latin words, combined with
          a handful of model sentence structures, to generate Lorem Ipsum which
          looks reasonable. The generated Lorem Ipsum is therefore always free
          from repetition, injected humour, or non-characteristic words etc.
        </Texto>
      </Box>
    </>
  );
};

export default VersioningFrame;
