import { Skeleton, SkeletonPropsVariantOverrides, SkeletonTypeMap } from '@mui/material';

type TProps = {
  width?: number | string;
  height?: number | string;
  animation?: 'pulse' | 'wave' | false;
};

const Esqueleto: React.FC<TProps> = ({ width, height, animation }) => {
  return <Skeleton width={width} height={height} animation={animation} variant='rectangular' style={{ opacity: 0.5 }} />;
};

export default Esqueleto;
