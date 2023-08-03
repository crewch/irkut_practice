import { Box, Divider, List } from '@mui/material'
import { Navigate, Outlet } from 'react-router-dom'
import ButtonListItem from '../../components/layout/ButtonListItem/ButtonListItem'
import LogoListItem from '../../components/layout/LogoListItem/LogoListItem'
import { useGetUserData } from '../../hooks/userDataHook'
import { ReactComponent as Analysis } from '/src/assets/analysis.svg'
import { ReactComponent as Confirmation } from '/src/assets/confirmation.svg'
import { ReactComponent as Document } from '/src/assets/document.svg'
import { ReactComponent as Key } from '/src/assets/key.svg'
import { ReactComponent as Notification } from '/src/assets/notification.svg'
import { ReactComponent as Settings } from '/src/assets/settings.svg'
import { ReactComponent as User } from '/src/assets/user1.svg'
import styles from './Layout.module.scss'

const Layout = () => {
	if (!useGetUserData()) {
		return <Navigate to='/login' />
	}

	return (
		<Box className={styles.container}>
			<Box component='nav' className={styles.nav}>
				<List>
					<LogoListItem pathImg='/logo.svg' />
					<Divider variant='middle' className={styles.divider} />
					<ButtonListItem
						Img={Document}
						to='release'
						label='Выпускаемые процессы'
					/>
					<ButtonListItem
						Img={Confirmation}
						to='approval'
						label='Этапы на согласование'
					/>
					<ButtonListItem
						Img={Analysis}
						to='analysis'
						label='Аналитика'
						otherPage='http://localhost:3000'
					/>
					<ButtonListItem Img={Key} to='/404' label='Страница админа' />
				</List>
				<List>
					<Divider variant='middle' className={styles.divider} />
					<ButtonListItem Img={Notification} to='/404' label='Уведомления' />
					<ButtonListItem Img={Settings} to='/404' label='Настройки' />
					<ButtonListItem Img={User} to='/404' label='Страница пользователя' />
				</List>
			</Box>
			<Outlet />
		</Box>
	)
}

export default Layout
