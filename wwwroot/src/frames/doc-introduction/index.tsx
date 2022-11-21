import { Box } from '@mui/material';
import Texto from '../../components/texto';

const IntroductionFrame = () => {
  return (
    <>
      <Box className='introduction-summary'>
        <Texto
          styles={{
            fontSize: '1.4rem',
            fontFamily: 'Roboto-regular',
            fontWeight: '400',
            color: '#e2e2e2',
            lineHeight: '1.8rem',
            textAlign: 'left',
            marginBottom: '20px',
          }}>
          Introduction
        </Texto>
        <Texto
          styles={{
            fontSize: '0.9rem',
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
          there isn't anything embarrassing hidden in the middle of text. <br />{' '}
          All the Lorem Ipsum generators on the Internet tend to repeat
          predefined chunks as necessary, making this the first true generator
          on the Internet. It uses a dictionary of over 200 Latin words,
          combined with a handful of model sentence structures, to generate
          Lorem Ipsum which looks reasonable. <br />
          <br /> The generated Lorem Ipsum is therefore always free from
          repetition, injected humour, or non-characteristic words etc, or
          non-characteristic words etc, over 200 Latin words a passage of Lorem
          Ipsum.
        </Texto>
        <Texto
          styles={{
            fontSize: '1.4rem',
            fontFamily: 'Roboto-regular',
            fontWeight: '400',
            color: '#e2e2e2',
            lineHeight: '1.8rem',
            textAlign: 'left',
            marginBottom: '20px',
          }}>
          REST API
        </Texto>
        <Texto
          styles={{
            fontSize: '0.9rem',
            fontFamily: 'Roboto-light',
            fontWeight: '100',
            color: '#bbbbbb',
            textTransform: 'none',
            padding: '0 5% 3% 1%',
          }}>
          It is a long established fact that a reader will be distracted by the
          readable content of a page when looking at its layout. The point of
          using Lorem Ipsum is that it has a more-or-less normal distribution of
          letters, as opposed to using 'Content here, content here', making it
          look like readable English. Many desktop publishing packages and web
          page editors now use Lorem Ipsum as their default model text.
          <br /> and a search for 'lorem ipsum' will uncover many web sites
          still in their infancy. Various versions have evolved over the years,
          sometimes by accident, sometimes on purpose (injected humour and the
          like).
        </Texto>
      </Box>
    </>
  );
};

export default IntroductionFrame;
