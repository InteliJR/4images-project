import React from 'react';
import styled from 'styled-components';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'; 
import { faWhatsapp } from '@fortawesome/free-brands-svg-icons';

const Container = styled.footer`
    width: 100dvw;
    padding: 3px;   
    background-color: #FFFFFF;
    display: flex;
    border: 3px;
`;

const TextContainer = styled.div`
    width: 60%;
    justify-content: left;
    align-items: left;
    text-align: left;
    margin-left: 15px;
`

const Title = styled.h1`
    padding: 3px;
    font-size: 1.5em;
    color: #303030;
    font-family: inter;

`;

const Text = styled.p`
    padding: 3px;
    font-size: 1em;
    color: #303030;
    font-family: inter;
`;

const IconContainer = styled.div`
    margin-top: 15px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    margin-left: auto;
    margin-right: auto;
`;

const Icon = styled(FontAwesomeIcon)`
    padding: 3px;
    font-size: 4em;
    align-self:center
    margin: 0;
`;

const IconText = styled.p`
    padding: 3px;
    font-size: 1em;
    font-family: inter;
`

const Footer = () => {
    return (
        <Container>
            <TextContainer>
                <Title>Não encontrou o que queria?</Title>
                <Text>Entre em contato com nossa equipe e solicite uma foto personalizada, basta clicar no botão ao lado ou mandar uma mensagem no nosso Whastapp</Text>
            </TextContainer>
            <IconContainer>
                <Icon icon={faWhatsapp} />
                <IconText>(XX) XXXX-XXXX </IconText>
            </IconContainer>
        </Container>
    )
}

export default Footer;