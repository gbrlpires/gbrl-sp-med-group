import React from 'react';
import avatar from '../../assets/img/avatar.png';


import './StatusBar.css'

function StatusBar() {
    return(
        <div className="status-bar wrapper">
        <div className="status-bar-flexbox status-bar-container">
            <img className="status-bar__img" src={avatar} />
            {/* deixar aqui dinamico de acordo com a hora do dia */}
            <span className="status-bar__welcome">Bom dia!</span> 
    
            {/* deixar aqui dinâmico de acordo com a tela */}
            <span className="status-bar__title">Entrar</span>
        </div>
        </div>
     
        
  );
  }
  
  export default StatusBar;