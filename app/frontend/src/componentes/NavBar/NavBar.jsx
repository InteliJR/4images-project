import React from 'react';
import styled from 'styled-components';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'; 
import { faUser } from '@fortawesome/free-solid-svg-icons';

const Container = styled.div`
    width: 100dvw;
    padding: 3px;   
    background-color: #FFFFFF;
    display: flex;
    border: 3px;
    border-bottom: solid 1px #D3D3D3;
`;

const Logo = styled.p`
    font-size: 1.5em;
    font-family: inter;
    margin-left: 15px;
    color: #5B5B5B; 
`

const SearchBar = styled.div`
    width: 50%;
`

const OptionsContainer = styled.div`
    display: flex;
    justify-content: center;
    align-items: center;
`

const Menu = styled.p`
    padding: 1em;
    font-size: 1em;
    font-family: inter;
    color: #5B5B5B;
`

const OptionsIcon = styled(FontAwesomeIcon)`
    font-size: 1.5em;
    padding: 3px;
    padding-left: 1em;
    display: flex;
    margin-left: 10px;
    border-left: solid 1px #D3D3D3;
`

const Text = styled.p`
    font-size: 1em;
    font-family: inter;
`

const NavBar = () => {
    return (
        <Container>
            <Logo>4Imagens</Logo>
            <SearchBar></SearchBar>
            <OptionsContainer>
                <Menu>Início</Menu>
                <Menu>Coleções</Menu>
                <Menu>Curtidas</Menu>
                <Menu>Transações</Menu>
                <OptionsIcon icon={faUser}></OptionsIcon>
            </OptionsContainer>
        </Container>
    )
}

export default NavBar;