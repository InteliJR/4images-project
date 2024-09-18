import React from 'react';
import { Link } from 'react-router-dom';
import styled from 'styled-components';

const AppContainer = styled.div`
  text-align: center;
  font-family: Arial, sans-serif;
  background-color: #f0f8ff;
  min-height: 100vh;
  padding: 1dvw;
`;

const Title = styled.h1`
  color: #333;
  font-size: 3dvw;
  margin-bottom: 1dvw;
`;

const Nav = styled.nav`
  margin-top: 1dvw;
`;

const List = styled.ul`
  list-style-type: none;
  padding: 0;
`;

const ListItem = styled.li`
  display: inline;
  margin: 0 1dvw;
`;

const StyledLink = styled(Link)`
  color: #007BFF;
  text-decoration: none;
  font-size: 2dvw;
  font-weight: bold;

  &:hover {
    color: #0056b3;
    text-decoration: underline;
  }
`;

const App = () => {
  return (
    <AppContainer>
      <Title>Bem-vindo ao Blob Storage Viewer</Title>
      <Nav>
        <List>
          <ListItem><StyledLink to="/joao">João</StyledLink></ListItem>
          <ListItem><StyledLink to="/raissa">Raissa</StyledLink></ListItem>
          <ListItem><StyledLink to="/gabriel">Gabriel</StyledLink></ListItem>
          <ListItem><StyledLink to="/mirella">Mirella</StyledLink></ListItem>
        </List>
      </Nav>
    </AppContainer>
  );
}

export default App;
