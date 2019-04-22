import React, { Component } from 'react';

function Navbar() {
  return(
    <header className="header">
        <div className="wrapper header-flexbox">
            <nav className="navbar">
                <ul className="navbar__list">
                    <li className="navbar__list-item"><a href="">Sobre</a></li>
                    <li className="navbar__list-item"><a href="">Quero Participar</a></li>
                    <li className="navbar__list-item"><a href="">Quero Apoiar</a></li>
                    <li className="navbar__list-item"><a href="">Contato</a></li>
                </ul>
            </nav>
        </div>
    </header>
      
);
}

export default Navbar;