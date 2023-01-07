import React, { createContext, useContext, useState } from 'react';

type CarregamentoContextoProps = {
  isImgCarregando: boolean;
  setImgCarregando: (ImgCarregando: boolean) => void;
};

type CarregamentoProviderProps = {
  children?: React.ReactNode;
};

const ContextoCarregamento = createContext<CarregamentoContextoProps>({} as CarregamentoContextoProps);

const CarregamentoImgProvider = ({ children }: CarregamentoProviderProps) => {
  const [isImgCarregando, setImgCarregando] = useState(true);

  return (
    <ContextoCarregamento.Provider
      value={{
        isImgCarregando,
        setImgCarregando,
      }}>
      {children}
    </ContextoCarregamento.Provider>
  );
};

const useProgresso = () => {
  const contextoProgressoCircular = useContext(ContextoCarregamento);
  return contextoProgressoCircular;
};

export { ContextoCarregamento, CarregamentoImgProvider, useProgresso };
