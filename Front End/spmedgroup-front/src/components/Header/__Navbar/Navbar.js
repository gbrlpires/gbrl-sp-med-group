import React, { Component } from 'react';

import './Navbar.css';

function Navbar() {
  return(
        <nav className="navbar">
            <ul className="navbar__list">
                <li className="navbar__list-item"><a href="">Sobre</a></li>
                <li className="navbar__list-item"><a href="">Especialidades</a></li>
                <li className="navbar__list-item"><a href="">Agendar Consulta</a></li>
                <li className="navbar__list-item"><a href="">Ver Consultas</a></li>
                <li className="navbar__list-item"><a href="">Cadastrar Usuário</a></li>
                <li className="navbar__list-item"><a href="">Sair</a></li>
            </ul>
        </nav>     
);
}

export default Navbar;