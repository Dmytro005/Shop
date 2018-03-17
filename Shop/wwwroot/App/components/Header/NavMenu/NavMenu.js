import React from 'react';
import './NavManu.scss';

export const NavMenu = () => {
	return (
		<div className="menu-container">
			<nav className="navbar navbar-expand-lg navbar-light bg-light">
				<a className="navbar-brand" href="#">Navbar</a>
				<button className="navbar-toggler" type="button" data-toggle="collapse"
						data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
						aria-expanded="false" aria-label="Toggle navigation">
					<span className="navbar-toggler-icon"></span>
				</button>

				<div className="collapse navbar-collapse" id="navbarSupportedContent">
					<div className="form-inline my-2 my-lg-0">
						<input className="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search"/>
						<button className="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
					</div>
				</div>
			</nav>
		</div>
	);
};